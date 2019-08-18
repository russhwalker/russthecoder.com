import React from "react"
import { graphql } from "gatsby"

import Bio from "../components/bio"
import Layout from "../components/layout"
import SEO from "../components/seo"

class Contact extends React.Component {
  render() {
    const { data } = this.props
    const siteTitle = data.site.siteMetadata.title

    return (
      <Layout location={this.props.location} title={siteTitle}>
        <SEO title="Contact Russ" />
        <Bio />
        <h3>Get In Touch</h3>
        <ul>
          <li><a href="mailto:russ@russthecoder.com">russ@russthecoder.com</a></li>
          <li><a href="https://github.com/russhwalker/" target="_blank" rel="noopener noreferrer">GitHub</a></li>
          <li><a href="https://www.linkedin.com/in/russellhwalker/" target="_blank" rel="noopener noreferrer">LinkedIn</a></li>
          </ul>
      </Layout>
    )
  }
}

export default Contact

export const pageQuery = graphql`
  query {
    site {
      siteMetadata {
        title
      }
    }
  }
`